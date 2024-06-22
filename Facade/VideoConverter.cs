namespace Facade
{
    public class VideoConverter
    {
        private VideoFileReader _videoFileReader;
        private AudioExtractor _audioExtractor;
        private VideoDecoder _videoDecoder;
        private AudioDecoder _audioDecoder;
        private VideoEncoder _videoEncoder;
        private AudioEncoder _audioEncoder;
        private Muxer _muxer;

        public VideoConverter()
        {
            _videoFileReader = new VideoFileReader();
            _audioExtractor = new AudioExtractor();
            _videoDecoder = new VideoDecoder();
            _audioDecoder = new AudioDecoder();
            _videoEncoder = new VideoEncoder();
            _audioEncoder = new AudioEncoder();
            _muxer = new Muxer();
        }

        public void Convert(string inputFilePath, string outputFilePath, string outputFormat)
        {
            _videoFileReader.Read(inputFilePath);
            _audioExtractor.ExtractAudio(inputFilePath);
            _videoDecoder.DecodeVideo(inputFilePath);
            _audioDecoder.DecodeAudio(inputFilePath);
            _videoEncoder.EncodeVideo(outputFormat);
            _audioEncoder.EncodeAudio(outputFormat);
            _muxer.Mux(outputFilePath);
        }
    }
}
