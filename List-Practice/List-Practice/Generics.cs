using System;
using List_Practice.Models;

namespace List_Practice
{
	public class Generics <T> where T : BaseEntity
	{
		private T[] _datas;
		public Generics()
		{
			_datas = new T[0];	
		}

		public T[] Add(T item)
		{
			Array.Resize(ref _datas, _datas.Length + 1);
			_datas[_datas.Length - 1] = item;
			return _datas;
		}

		public T[] ShowAll() => _datas;


		public T GetById(int id) => _datas.FirstOrDefault(m => m.Id == id);


		public void  Delete(int id)
		{
			_datas = _datas.Where(m => m.Id != id).ToArray();
		}
    }	
}

