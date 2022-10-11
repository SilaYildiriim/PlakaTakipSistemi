using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;

namespace PlakaTakipSistemi
{
    class StateObject
    {
        public Socket workSocket = null;
        public const int BufferSize = 1024*1024;
        public byte[] buffer = new byte[BufferSize];
        public StringBuilder errorList = new StringBuilder();
    }
}
