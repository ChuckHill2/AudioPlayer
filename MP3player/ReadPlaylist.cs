//--------------------------------------------------------------------------
// <summary>
//   
// </summary>
// <copyright file="ReadPlaylist.cs" company="Chuck Hill">
// Copyright (c) 2020 Chuck Hill.
//
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public License
// as published by the Free Software Foundation; either version 2.1
// of the License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// The GNU Lesser General Public License can be viewed at
// http://www.opensource.org/licenses/lgpl-license.php. If
// you unfamiliar with this license or have questions about
// it, here is an http://www.gnu.org/licenses/gpl-faq.html.
//
// All code and executables are provided "as is" with no warranty
// either express or implied. The author accepts no liability for
// any damage or loss of business that this product may cause.
// </copyright>
// <repository>https://github.com/ChuckHill2/AudioPlayer</repository>
// <author>Chuck Hill</author>
//--------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace MP3player
{
    public static class ReadPlaylist
    {
        public static string[] Makeplaylist(string playlistFile)
        {
            if (string.IsNullOrWhiteSpace(playlistFile)) return new string[0];
            playlistFile = GetFullPath(playlistFile);
            if (playlistFile==null || !File.Exists(playlistFile)) return new string[0];

            if (playlistFile.EndsWith(".wpl", StringComparison.CurrentCultureIgnoreCase))
                return MakeplaylistWPL(playlistFile);
            else if (playlistFile.EndsWith(".m3u", StringComparison.CurrentCultureIgnoreCase))
                return MakeplaylistM3U(playlistFile);
            else
                return new string[] { playlistFile };
        }

        private static string[] MakeplaylistWPL(string playlistFile)
        {
            using (var readList = new XmlTextReader(playlistFile))
            {
                var folder = Path.GetFileName(playlistFile);
                var name = new List<string>();
                while (readList.Read())
                {
                    if (readList.NodeType == XmlNodeType.Element)
                    {
                        if (readList.LocalName.Equals("media"))
                        {
                            var fn = GetFullPath(readList.GetAttribute(0).ToString().Trim());
                            if (fn == null) continue;
                            if (!File.Exists(fn))
                            {
                                fn = Path.Combine(folder, Path.GetFileName(fn));
                                if (!File.Exists(fn)) continue;
                            }
                            name.Add(fn);
                        }
                    }
                }
                return name.ToArray();
            }
        }

        private static string[] MakeplaylistM3U(string playlistFile)
        {
            using(var sr = new StreamReader(playlistFile))
            {
                var name = new List<string>();
                string line;
                var folder = Path.GetFileName(playlistFile);
                
                while ((line = sr.ReadLine())!=null)
                {
                    line = line.Trim();
                    if (line.Length == 0) continue;
                    if (line[0] == '#') continue;
                    if (!File.Exists(line))
                    {
                        line = Path.Combine(folder, Path.GetFileName(line));
                        if (!File.Exists(line)) continue;
                    }
                    name.Add(line);
                }
                return name.ToArray();
            }
        }

        private static string GetFullPath(string fn)
        {
            if (string.IsNullOrWhiteSpace(fn)) return null;
            try
            {
                fn = Path.GetFullPath(fn);
            }
            catch
            {
                return null;
            }
            return fn;
        }
    }
}
