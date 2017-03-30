namespace Plugin.FilePicker.Abstractions
{
    /// <summary>
    /// The object used as a wrapper for the file picked by the user
    /// </summary>
    public class FileData
    {
        public FileData()
        { }

        public FileData(byte[] dataArray, string filePath, string fileName)
        {
            DataArray = dataArray;
            FilePath = filePath;
            FileName = fileName;
        }

        /// <summary>
        /// Content of the picked file
        /// </summary>
        public byte[] DataArray { get; }

        /// <summary>
        /// Filename of the picked file
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Full filepath of the picked file
        /// </summary>
        public string FilePath { get; set; }
    }
}