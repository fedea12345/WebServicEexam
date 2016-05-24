using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities;
using Dalc;

namespace WebSHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProductService" in both code and config file together.
    [ServiceContract]
    public class IProductService : IService1
    {       
      public List<ProductDTO> GetListaProduct()
        {
            
            List<Product> produc = new List<Product>();
            produc = DalcProduct.GetProducts();



            var config = new MapperConfiguration(cfg => cfg.CreateMap<Product,ProductDTO >());
            var mapper = config.CreateMapper();

            List<ProductDTO> proDTO = mapper.Map<List<ProductDTO>>(produc);
            return proDTO;

        }
     
    }
    [DataContract]
    public class ProductDTO
    {
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public decimal? UnitPrice { get; set; }
    }
}
