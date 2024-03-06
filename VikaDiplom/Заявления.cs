//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Заявления
    {
        public int Код { get; set; }
        public System.DateTime ДатаЗаявки { get; set; } = DateTime.Now;
        public int КодОпекуна { get; set; }
        public int КодРебенка { get; set; }
        public int ТипЗаявленияКод { get; set; }
        public Nullable<int> РешениеОпекиКод { get; set; }
        public Nullable<System.DateTime> ДатаПринятияРешения { get; set; } = DateTime.Now;
        public string КомментарийРешения { get; set; }
    
        public virtual Дети Дети { get; set; }
        public virtual Опекуны Опекуны { get; set; }
        public virtual РешениеОпеки РешениеОпеки { get; set; }
        public virtual ТипЗаявления ТипЗаявления { get; set; }
    }
}
