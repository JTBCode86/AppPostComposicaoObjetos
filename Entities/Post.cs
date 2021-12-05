using System;
using System.Text;
using System.Collections.Generic;

namespace AppPostComposicaoObjetos.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }

        public string Commet { get; set; }

        public int Likes{ get; set; }

        public List<Comment> Coments { get; set; } = new List<Comment>();

        public Post()
        {

        }

        public Post(DateTime moment, string title, string commet, int likes)
        {
            this.Moment = moment;
            this.Title = title;
            this.Commet = commet;
            this.Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Coments.Add(comment);
        }

        public void RemoveComment(Comment comment) 
        {
            Coments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Commet);
            sb.AppendLine("Coments: ");
            
            foreach (Comment c in Coments)
            {
                sb.AppendLine(c.Text);
            }
            
            return sb.ToString();
        }
    }
}
