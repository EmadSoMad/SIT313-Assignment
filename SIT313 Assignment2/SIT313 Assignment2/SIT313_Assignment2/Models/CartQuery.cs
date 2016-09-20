﻿using SQLite.Net;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace SIT313_Assignment2.Models
{
    public class CartQuery
    {
        static object locker = new object();

        SQLiteConnection s;

        public CartQuery()
        {
            s = DependencyService.Get<IProducts>().GetConnection();
            s.CreateTable<CartRecord>();
        }

        //Insert 
        public int InsertDetails(CartRecord custDB)
        {
            lock (locker)
            {
                return s.Insert(custDB);
            }
        }

        //Update 
        public int UpdateDetails(CartRecord custDB)
        {
            lock (locker)
            {
                return s.Update(custDB);
            }
        }

        //Delete 
        public int DeleteNote(int id)
        {
            lock (locker)
            {
                return s.Delete<CartRecord>(id);
            }
        }

        //Get all 
        public IEnumerable<CartRecord> GetList()
        {
            lock (locker)
            {
                return (from i in s.Table<CartRecord>() select i).ToList();
            }
        }



        //Dispose
        public void Dispose()
        {
            s.Dispose();
        }
    }
}
