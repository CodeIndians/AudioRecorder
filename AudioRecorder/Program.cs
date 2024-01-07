// See https://aka.ms/new-console-template for more information


using AudioRecorder;
using System.Runtime.InteropServices;

void appFunction()
{
    WinMMBase.WAVEFORMATEX wavFmt = new WinMMBase.WAVEFORMATEX();

    wavFmt.wFormatTag = 1;//pcm
    wavFmt.nChannels = 2;//stereo
    wavFmt.nSamplesPerSec = 44100;//44100 samples per sec
    wavFmt.nAvgBytesPerSec = 176400;//2 channels*2 bytes * 44100 samples 
    wavFmt.wBitsPerSample = 16;//16 bits per sample
    wavFmt.nBlockAlign = (ushort)(wavFmt.nChannels * wavFmt.wBitsPerSample / 8);
    wavFmt.cbSize = (ushort)Marshal.SizeOf(wavFmt);

    var recorder = new Record(wavFmt);

    //TODO: skipping event registers for now 

    //TODO:  sending 0 for now 
    Console.WriteLine("Start Recording");
    recorder.StartRecording(0);

    // sleep for 3 seconds
    Thread.Sleep(5000);

    Console.WriteLine("Stop Recording");
    recorder.StopRecording();

}


appFunction();
