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
        // Required bloquea para que seja necessário passar um valor 
        [Required(ErrorMessage = "O campo título é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo diretor é obrigatório")]
        public string Diretor{ get; set; }
        //StringLength faz com que tenha no máximo 30 caracteres
        [StringLength(30, ErrorMessage ="O campo gênero deve ter no máximo 30 caracteres")]
        public string Genero { get; set; }
        // range faz com que tenha no minimo 1 minuto e no maximo 600
        [Range(10, 600, ErrorMessage ="A duração deve ter no mínimo 10 minutos e no máximo 600 minutos")]
        public int Duracao { get; set; }
    }
}
