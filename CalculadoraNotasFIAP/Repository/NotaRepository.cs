using CalculadoraNotasFIAP.Models;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraNotasFIAP.Repository
{
    public class NotaRepository
    {
        public static List<Nota> _notas = new List<Nota>();

        public static void Inserir(Nota nota)
        {
            _notas.Add(nota);
        }

        public static List<Nota> Listar()
        {
            return _notas;
        }

        public static Nota ListarPorRm(string rm)
        {
            return _notas.SingleOrDefault(n => n.Rm == rm);
        }

        public static void Editar(Nota nota)
        {
            _notas.Where(n => n.Rm == nota.Rm)
                .ToList().ForEach(n =>
                {
                    n.Nac = nota.Nac;
                    n.Am = nota.Am;
                    n.Ps = nota.Ps;
                    n.Media = nota.Media;
                });
        }

        public static void Deletar(string rm)
        {
            _notas.Remove(ListarPorRm(rm));
        }
    }
}