using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "O campo título é obrigatório!"), StringLength(50, ErrorMessage = "O campo título não pode ultrapassar 50 caracteres!")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é obrigatório!"), StringLength(30, ErrorMessage = "O campo Diretor não pode ultrapassar 30 caracteres!")]
        public string Diretor { get; set; }
        [Required(ErrorMessage = "O campo Gênero é obrigatório!"), StringLength(30, ErrorMessage = "O gênero não pode ultrapassar 30 caracteres!")]
        public string Genero { get; set; }
        [Range(1, 300, ErrorMessage = "A duração do filme não pode passar de 300 minutos!")]
        public int Duracao { get; set; }

    }
}
