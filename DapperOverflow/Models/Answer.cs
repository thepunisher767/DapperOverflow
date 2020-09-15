using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Dapper;

namespace DapperOverflow.Models
{
    [Table("Answer")]
    public class Answer
    {
        [Key]
        public long id { get; set; }
        public string Username { get; set; }
        public string Detail { get; set; }
        public long QuestionID { get; set; }
        public DateTime Posted { get; set; }
        public int Upvotes { get; set; }


        public static Answer Create(string _username, long _questionid, string _detail)
        {
            IDbConnection db = new SqlConnection("Server=.;Database=DapperOverflow;user id=dbuser;password=abc123");
            Answer newanswer = new Answer() { Username = _username, QuestionID = _questionid, Detail = _detail };
            newanswer.Posted = DateTime.Now;
            long _id = db.Insert<Answer>(newanswer);
            newanswer.id = _id;
            return newanswer;
        }

    }
}
