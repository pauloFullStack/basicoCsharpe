﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LINQOperadoresDeOrdenacao
{
    internal class FonteDeDados
    {

        public static int[] GetIdades()
        {
            var idades = new[] { 30, 33, 35, 36, 40, 30, 33, 36, 30, 40 };
            return idades;
        }

        public static string[] GetNomes()
        {
            var nomes = new[] { "Paulo", "MARIA", "paulo", "Amanda", "maria", "amanda" };
            return nomes;
        }

        public static string[] GetPaises1()
        {
            var paises = new[] { "Brasil", "USA", "UK", "Argentina", "China" };
            return paises;
        }

        public static List<int> GetNumeros()
        {
            List<int> numeros = new List<int>()
            {
                1,2,4,8,16,32,64,128,256,512
            };
            return numeros;
        }

        public static List<int> GetListaNegra()
        {
            List<int> numeros = new List<int>()
            {
                16,128,512
            };

            return numeros;
        }

        public static List<Aluno> GetAlunos()
        {
            List<Aluno> alunos = new List<Aluno>()
            {
                new Aluno(){Nome = "Maria", Idade = 36, Nota = 7, Cursos = new List<string> {"VB.NET","ASP.NET"} },
                new Aluno(){Nome = "Manoel", Idade = 33, Nota = 6, Cursos = new List<string> {"C#","EF Core"}},
                new Aluno(){Nome = "Amanda", Idade = 21, Nota = 5, Cursos = new List<string> {"Java","Node"}},
                new Aluno(){Nome = "Carlos", Idade = 18, Nota = 9, Cursos = new List < string > { "C++", "MongoDB", "Node" }},
                new Aluno(){Nome = "Jaime", Idade = 36, Nota = 9, Cursos = new List < string > { "C++", "MongoDB", "Node" }},
                new Aluno(){Nome = "Debora", Idade = 33, Nota = 4, Cursos = new List < string > { "TypeScript", "React", "Node" }},
                new Aluno(){Nome = "Alicia", Idade = 18, Nota = 4, Cursos = new List < string > { "TypeScript", "React", "Node" }},
                new Aluno(){Nome = "Sandra", Idade = 19, Nota = 4, Cursos = new List < string > { "TypeScript", "React", "Node" }},
            };

            return alunos;
        }


        public static List<Aluno> GetTurmaA()
        {
            List<Aluno> alunos = new()
            {
                new Aluno(){Nome = "Maria", Idade = 36, Nascimento = new DateTime(2001,6,11)},
                new Aluno(){Nome = "Manoel", Idade = 33, Nascimento = new DateTime(2000,2,10)},
                new Aluno(){Nome = "Amanda", Idade = 21, Nascimento = new DateTime(1986,9,30)},
                new Aluno(){Nome = "Carlos", Idade = 18, Nascimento = new DateTime(1999,10,11)},
                new Aluno(){Nome = "Jaime", Idade = 36, Nascimento = new DateTime(1988,9,15)}
            };

            return alunos;
        }

        public static List<Aluno> GetTurmaB()
        {
            List<Aluno> alunos = new()
            {
                new Aluno(){Nome = "Homero", Idade = 26, Nascimento = new DateTime(1988,9,15)},
                new Aluno(){Nome = "Silvia", Idade = 31, Nascimento = new DateTime(2001,9,30)},
                new Aluno(){Nome = "Felicio", Idade = 21, Nascimento = new DateTime(1986,9,30)},
                new Aluno(){Nome = "Carlos", Idade = 18, Nascimento = new DateTime(2002,8,15)},
                new Aluno(){Nome = "Alfredo", Idade = 33, Nascimento = new DateTime(1999,10,11)},
                new Aluno(){Nome = "Denize", Idade = 30, Nascimento = new DateTime(2004,11,5)}
            };

            return alunos;
        }

    }
}
