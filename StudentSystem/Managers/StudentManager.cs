using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Managers
{
    class StudentManager
    {
        Student[] data = new Student[0];

        public void Add(Student entity)
        {
            int len = data.Length;
            Array.Resize(ref data, len + 1);
            data[len] = entity;
        }

        public Student[] GetAll()
        {
            return data;
        }
    }
}
