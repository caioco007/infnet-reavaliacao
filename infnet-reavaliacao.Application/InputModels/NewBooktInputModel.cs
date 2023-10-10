using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infnet_reavaliacao.Application.InputModels
{
    public class NewBooktInputModel
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int IdAuthor { get; private set; }
    }
}
