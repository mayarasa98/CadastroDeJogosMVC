using Cadastro_de_jogos_MVC_16._1_Mayara.DAO;
using Cadastro_de_jogos_MVC_16._1_Mayara.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Cadastro_de_jogos_MVC_16._1_Mayara.Controllers
{
    public class JogoController : Controller
    {
        // Método responsável por listar todos os jogos em uma página.
        public IActionResult Index()
        {
            JogoDAO dao = new JogoDAO();
            List<JogoViewModel> lista = dao.Lista();
            return View(lista);
        }

        public IActionResult Create()
        {
            try
            {
                JogoViewModel jogo = new JogoViewModel();              
                jogo.DataAquisicao = DateTime.Now;

                JogoDAO dao = new JogoDAO();
                jogo.Id = dao.ProximoId();

                return View("Form", jogo);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
            
        }

        public IActionResult Salvar(JogoViewModel jogo)
        {
            try
            {
                JogoDAO dao = new JogoDAO();
                if (dao.Consulta(jogo.Id) == null)
                    dao.Inserir(jogo);
                else
                    dao.Alterar(jogo);
                
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
            
        }

        public IActionResult Edit (int id)
        {
            try
            {
                JogoDAO dao = new JogoDAO();
                JogoViewModel jogo = dao.Consulta(id);
                if (jogo == null)
                    return RedirectToAction("index");
                else
                    return View("Form", jogo);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                JogoDAO dao = new JogoDAO();
                dao.Excluir(id);
                return RedirectToAction("index");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }
    }
}
