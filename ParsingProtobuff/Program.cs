using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;
namespace ParsingProtobuff
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] file = default;
            if (File.Exists(@"c:\Users\Александр\Desktop\proto.chls"))
            {
                file = File.ReadAllBytes(@"c:\Users\Александр\Desktop\speedup_job_allow_tokens");
            }
            Stream stream = new MemoryStream(file);
            var r = Google.Protobuf.CodedOutputStream.ComputeBytesSize(ByteString.CopyFrom(file));

            var result = CodedInputStream.CreateWithLimits(stream, 65534, 65534);
        }
    }
}
