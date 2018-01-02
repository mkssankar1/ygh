using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace GreenChits.Common.Utility
{
    public static class FileCompression
    {
        /// <summary>
        /// Compresses the specified file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public static void Compress(string filePath)
        {
            FileInfo fInfo = new FileInfo(filePath);

            if (fInfo.Exists)
            {
                // Get the stream of the source file.
                using (FileStream inFile = fInfo.OpenRead())
                {
                    // Prevent compressing hidden and 
                    // already compressed files.
                    if ((File.GetAttributes(fInfo.FullName)
                        & FileAttributes.Hidden)
                        != FileAttributes.Hidden & fInfo.Extension != ".gz")
                    {
                        // Create the compressed file.
                        using (FileStream outFile =
                                    File.Create(fInfo.FullName + ".gz"))
                        {
                            using (GZipStream Compress =
                                new GZipStream(outFile,
                                CompressionMode.Compress))
                            {
                                // Copy the source file into 
                                // the compression stream.
                                inFile.CopyTo(Compress);

                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// DeCompresses the specified file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public static void DeCompress(string filePath)
        {
            FileInfo fInfo = new FileInfo(filePath);

            if (fInfo.Exists)
            {
                // Get the stream of the source file.
                using (FileStream inFile = fInfo.OpenRead())
                {
                    // Get original file extension, for example
                    // "doc" from report.doc.gz.
                    string curFile = fInfo.FullName;
                    string origName = curFile.Remove(curFile.Length -
                            fInfo.Extension.Length);

                    //Create the decompressed file.
                    using (FileStream outFile = File.Create(origName))
                    {
                        using (GZipStream Decompress = new GZipStream(inFile,
                                CompressionMode.Decompress))
                        {
                            // Copy the decompression stream 
                            // into the output file.
                            Decompress.CopyTo(outFile);
                        }
                    }
                }
            }
        }
    }
}
