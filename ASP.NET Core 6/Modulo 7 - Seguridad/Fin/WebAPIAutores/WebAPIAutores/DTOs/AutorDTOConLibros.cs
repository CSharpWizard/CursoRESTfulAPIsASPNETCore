﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIAutores.DTOs
{
    public class AutorDTOConLibros: AutorDTO
    {
        public List<LibroDTO> Libros { get; set; }
    }
}
