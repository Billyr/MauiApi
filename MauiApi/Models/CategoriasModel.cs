using MauiApi.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApi.Models
{
    public class CategoriasModel : BaseBinding
    {
        private List<Categoria> _categorias;

        public List<Categoria> Categorias { get { return _categorias; } set { SetValue(ref _categorias , value); } }

    }
}
