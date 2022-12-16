﻿
using WebProjeto.Models;

namespace WebProjeto.Helper
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario(UsuarioModel usuario);

        void RemoverSessaoUsuario();

        UsuarioModel BuscarSessaoDoUsuario();

    }
}
