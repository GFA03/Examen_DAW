﻿using Examen_DAW.Server.Models;
using Examen_DAW.Server.Models.DTOs;

namespace Examen_DAW.Server.Services.ProfesorService
{
    public interface IProfesorService
    {
        Task<List<Profesor>> GetAll();
        Task Create(ProfesorDTO profesorDto);

        void Delete(Guid id);
        Task Update(Profesor profesor);
    }
}
