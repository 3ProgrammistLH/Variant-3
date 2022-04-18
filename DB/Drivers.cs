namespace Кокарев_Вариант_3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drivers
    {
        [Key]
        [Column("Идентификатор (GUID)")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Идентификатор__GUID_ { get; set; }

        [Required]
        [StringLength(50)]
        public string Фамилия { get; set; }

        [Required]
        [StringLength(50)]
        public string Имя { get; set; }

        [Required]
        [StringLength(50)]
        public string Отчество { get; set; }

        [Column("Паспорт (серия и номер)")]
        [Required]
        [StringLength(50)]
        public string Паспорт__серия_и_номер_ { get; set; }

        [Column("Адрес регистрации")]
        [StringLength(300)]
        public string Адрес_регистрации { get; set; }

        [Column("Адрес проживания")]
        [StringLength(300)]
        public string Адрес_проживания { get; set; }

        [Column("Место работы")]
        [Required]
        [StringLength(100)]
        public string Место_работы { get; set; }

        [Required]
        [StringLength(150)]
        public string Должность { get; set; }

        [Column("Мобильный номер")]
        [Required]
        [StringLength(20)]
        public string Мобильный_номер { get; set; }

        [Required]
        [StringLength(300)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Фотография { get; set; }

        public string Замечания { get; set; }
    }
}
