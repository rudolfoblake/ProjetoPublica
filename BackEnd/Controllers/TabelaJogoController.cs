using System.Security.AccessControl;
using System;
using Microsoft.AspNetCore.Mvc;
using BackEnd.Models;
using BackEnd.Context;
using System.Threading.Tasks;


namespace BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]     
    
    public class TabelaJogoController : ControllerBase
    {
        private readonly IRepository _repositorio;

        public TabelaJogoController(IRepository repositorio)
        {
            _repositorio = repositorio;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _repositorio.GetAllJogosAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("{jogoId}")]
        public async Task<IActionResult> GetById(int jogoId)
        {
            try
            {
                var result = await _repositorio.GetJogoAsyncById(jogoId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpPut("{jogoId}")]
        public async Task<IActionResult> Put(int jogoId, TabelaJogo tabelaJogo)
        {
            try
            {
                var jogoCadastrado = await _repositorio.GetJogoAsyncById(jogoId);
                if (jogoCadastrado == null)
                {
                    return NotFound();
                }
                _repositorio.Update(tabelaJogo);

                if (await _repositorio.SaveChangesAsync())
                {
                    return Ok(tabelaJogo);
                }
            }   
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Post(TabelaJogo tabelaJogo)
        {
            try
            {
                _repositorio.Add(tabelaJogo);
                
                if (await _repositorio.SaveChangesAsync())
                {
                    return Ok(tabelaJogo);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
            return BadRequest();
        }

        [HttpDelete("{jogoId}")]
        public async Task<IActionResult> Delete(int jogoId)
        {
            try
            {
                var jogo = await _repositorio.GetJogoAsyncById(jogoId);
                if (jogo == null)
                {
                    return NotFound();
                }
                _repositorio.Delete(jogo);

                if (await _repositorio.SaveChangesAsync())
                {
                    return Ok(
                        new {
                            message = "Deletado!!"
                        }
                    );
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
            return BadRequest();
        }
    }
}