# MP3Player Demo using Widows Multimedia (WinMM) with mciSendString()

The entirety of the audio WinMM/mciSendString functionality is encapsulated in a single file *AudioPlayer.cs*.
MP3Payer exercises all of this functionality. 

AudioPlayer.cs API
* Opening audio files, streams and byte arrays.
* Start/Stop
* Close
* Pause/Continue
* Rewind/FastForward
* Stereo Volume/Balance, Left/Right Volume, Left/Right Mute
* Play Speed

Available events
* ErrorOccured event
* Sound completed/stopped event
* VolumeChanged event

Supported Audio Formats
* .aac, .adt, .adts, .aif, .aifc, .aiff, .au, .flac, .m4a, .mka, .mp2, .mp3, .snd, .wav, .wax, .wma

State is maintained across audio clips.

This is not thread-safe. Limitations of WinMM.

Written in C# with Visual Studio 2019 and .Net Framework 4.8.

The reason I created this is because I needed a way to play short alert mp3 sound clips in another project. Something that does not require yet another dll and is succinct and easy to use.
