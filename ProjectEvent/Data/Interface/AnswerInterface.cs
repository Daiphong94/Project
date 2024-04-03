﻿using Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interface
{
    public interface AnswerInterface
    {
        Task<Answer> GetById(int id);
        Task<IEnumerable<Answer>> GetAll();
        Task Add(Answer entity);
        Task Update(Answer entity);
        Task Delete(int id);
        Task SubmitAnswer(Answer answer);
    }
}
