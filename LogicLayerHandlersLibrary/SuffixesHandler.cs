 using DataAccessLibrary.Products;
using LogicLayerEntitiesLibrary.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayerHandlersLibrary
{
    public class SuffixesHandler
    {
        private IDBMediatorProducts dbHandlerProducts;
        List<Suffix> suffixes;
        

        public SuffixesHandler(IDBMediatorProducts dBMediatorProduct)
        {
            this.dbHandlerProducts = dBMediatorProduct;
            suffixes = dbHandlerProducts.GetAllSuffixes();
        }

        public IList<Suffix> Suffixes { get { return suffixes.AsReadOnly(); } }

        public void AddSuffix(Suffix suffix) 
        {
            if (CheckIfSuffixExist(suffix.Name)) throw new ArgumentException($"Suffix with the name {suffix.Name} and type {suffix.SuffixType} already exist");
            int id = dbHandlerProducts.InsertSuffix(suffix);
            if (id == 0) throw new Exception("Suffix has not been added successfully");
            suffix.Id = id;
            suffixes.Add(suffix);
        }

        public void UpdateSuffix (Suffix currentSuffix, Suffix newSuffix) 
        {

        }

        private bool CheckIfSuffixExist(string name) 
        {
            foreach (Suffix suffix in suffixes) 
            {
                if (suffix.Name.Equals(name)) return true;
            }
            return false;
        }

    } 
}
