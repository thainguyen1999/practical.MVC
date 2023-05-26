﻿using System.ComponentModel.DataAnnotations;

namespace practical.MVC.Entities
{
    public class Subject
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Mon hoc khong duoc de trong")]
        [StringLength(255, ErrorMessage = "ExamSubject phải là một chuỗi có độ dài tối đa là 255.")]
        public string Name { get; set; }
    }
}
