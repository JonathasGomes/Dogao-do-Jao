using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dogao_do_Jao.Models
{
    [Table("CarrinhoCompraItens")]
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }

        public Lanche lanche { get; set; }

        public int Quantidade { get; set;}

        [StringLength(200)]
        public string CarrinhoCompraId { get; set; }
    }
}
