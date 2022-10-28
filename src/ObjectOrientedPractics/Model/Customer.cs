﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупатели.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// ID покупателя.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// ФИО покупателя.
        /// </summary>
        private string _fullName;

        public Address Address { get; set; }

        /// <summary>
        /// Возвращает ID покупателя.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задает ФИО покупателя.
        /// </summary>
        public string FullName
        {
            get
            { 
                return _fullName;
            }
            set
            {
                ValueValidator.AssertStringNotNull(value, nameof(FullName));
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Customer"/> 
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextID();
            FullName = "Не заполнено";
            Address = new Address();
        }

        /// <summary>
        /// Создает экземпляр <see cref="Customer"/>
        /// </summary>
        /// <param name="fullName">ФИО. До 200 символов.</param>
        /// <param name="address">Адрес. До 500 символов.</param>
        public Customer(string fullName, Address address)
        {
            _id = IdGenerator.GetNextID();
            FullName = fullName;
            Address = address;
        }
    }
}
