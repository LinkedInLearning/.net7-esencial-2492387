using System.Formats.Tar;
using System.IO.Compression;

using var stream = File.OpenRead("/mnt/c/curso/dotnet-sdk-7.0.100-linux-x64.tar.gz");
using GZipStream gzip = new GZipStream(stream, CompressionMode.Decompress);
TarFile.ExtractToDirectory(gzip, "/home/rodrigo/tarcontent", true);
