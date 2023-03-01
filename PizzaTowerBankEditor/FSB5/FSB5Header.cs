using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTowerBankEditor.FSB5
{
    public struct FSB5Header
    {
        public FSB5Header() 
        {
        }
        public string Magic => "FB5";
        public int Version = 0;
        public int SampleNumber = 0;
        public int SampleHeaderSize = 0;
        public int NameTableSize = 0;
        public uint FSBFlags = 0;
        byte[] Unknown1 = new byte[8];
        byte[] Unknown2 = new byte[16];
        byte[] Unknown3 = new byte[16];
    }
}
