using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfinalproject
{
    public interface IFileHandler
    {
        public void Save(string path);
        public void Load(string path);
    }
}
