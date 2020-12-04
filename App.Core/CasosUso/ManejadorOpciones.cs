using App.Core.Entidades;
using App.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.CasosUso
{
    public class ManejadorOpciones<T> : IOperaciones<T> where T : EntidadBase
    {   
        private readonly IRepositorio<T> Repositorio;
        public ManejadorOpciones(IRepositorio<T> Repositorio)
        {
            this.Repositorio = Repositorio;
        }   
        public T Create(T Data)
        {
            return Repositorio.Create(Data);
        }
        public T Read(T Data)
        {
            return Repositorio.Get(Data.Id);
        }
        public T Find(Expression<Func<T, bool>> matchitem)
        {
            return Repositorio.Find(matchitem);
        }
        public IEnumerable<T> FindAllWhere(Expression<Func<T, bool>> matchitem)
        {
            return Repositorio.FindAllWhere(matchitem);
        }
        public IEnumerable<T> FindAllWhereTake(Expression<Func<T, bool>> matchitem, int count)
        {
            return Repositorio.FindAllWhereTake(matchitem, count);
        }

        public Task<IEnumerable<T>> FindAll()
        {
            return Repositorio.ReadAsync();
        }
        public IEnumerable<T> FindAllTake(int count)
        {
            return Repositorio.FindAllTake(count);
        }
        public T Update(T Data)
        {
            return Repositorio.Update(Data);
        }
        public T Delete(T Data)
        {
            return Repositorio.Delete(Data);
        }
        public int Count()
        {
            return Repositorio.Count();
        }
        public bool Exists(Expression<Func<T, bool>> matchitem)
        {
            return Repositorio.Exist(matchitem);
        }
        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> matchitem)
        {
            return await Repositorio.ExistAsync(matchitem);
        }
    }
}
