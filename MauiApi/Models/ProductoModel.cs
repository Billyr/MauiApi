using MauiApi.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApi.Models
{
    public class ProductoModel : BaseBinding
    {
        private List<Producto> _productos;

        public List<Producto> Productos { get { return _productos; } set { SetValue(ref _productos, value); } }
    }
}
