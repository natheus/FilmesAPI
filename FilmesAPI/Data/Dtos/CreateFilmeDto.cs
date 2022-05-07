using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é obrigatório!"), StringLength(30, ErrorMessage = "O campo Diretor não pode ultrapassar 30 caracteres!")]
        public string Diretor { get; set; }
        [Required(ErrorMessage = "O campo Gênero é obrigatório!"), StringLength(30, ErrorMessage = "O gênero não pode ultrapassar 30 caracteres!")]
        public string Genero { get; set; }
        [Range(1, 300, ErrorMessage = "A duração do filme não pode passar de 300 minutos!")]
        public int Duracao { get; set; }
        [Range(1, 10, ErrorMessage = "A nota deve ser de 1 ate 10!")]
        public double Nota { get; set; }
    }
}
