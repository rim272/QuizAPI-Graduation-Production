using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Net6CleanArchitectureQuizzApp.Domain.Entities;
public class Question : IEntity
    {
        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public QuestionType Type { get; set; }
        public string? AnswerDetails { get; set; } 
        public int QuizTestId { get; set; }
        public QuizTest? QuizTest { get; set; }
    public string ListOfCorrectAnswerIds { get; set; } 

    public ICollection<Reponse>? Reponses { get; set; } =  new List<Reponse>();


    }

