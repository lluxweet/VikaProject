﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VikaDiplom
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TaranovaDiplomEntities : DbContext
    {
        private static TaranovaDiplomEntities _context;
        public TaranovaDiplomEntities()
            : base("name=TaranovaDiplomEntities")
        {
        }
        public static TaranovaDiplomEntities GetContext()
        {
            if (_context == null)
                _context = new TaranovaDiplomEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Возраст> Возраст { get; set; }
        public virtual DbSet<Город> Город { get; set; }
        public virtual DbSet<Дети> Дети { get; set; }
        public virtual DbSet<Заявления> Заявления { get; set; }
        public virtual DbSet<КатегорияВозраста> КатегорияВозраста { get; set; }
        public virtual DbSet<КатегорияЗдоровья> КатегорияЗдоровья { get; set; }
        public virtual DbSet<Опекуны> Опекуны { get; set; }
        public virtual DbSet<Пол> Пол { get; set; }
        public virtual DbSet<Пользователи> Пользователи { get; set; }
        public virtual DbSet<Регион> Регион { get; set; }
        public virtual DbSet<РешениеОпеки> РешениеОпеки { get; set; }
        public virtual DbSet<ТипЗаявления> ТипЗаявления { get; set; }
        public virtual DbSet<ТипЛичности> ТипЛичности { get; set; }
        public virtual DbSet<Улица> Улица { get; set; }
        public virtual DbSet<ЦветВолос> ЦветВолос { get; set; }
        public virtual DbSet<ЦветГлаз> ЦветГлаз { get; set; }
        public virtual DbSet<ЦельОбращения> ЦельОбращения { get; set; }
    }
}