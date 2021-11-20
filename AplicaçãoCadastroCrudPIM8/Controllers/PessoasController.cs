using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AplicaçãoCadastroCrudPIM8.Models;

namespace AplicaçãoCadastroCrudPIM8.Controllers
{
    public class PessoasController : Controller
    {
        private readonly PessoaContext _context;

        public PessoasController(PessoaContext context)
        {
            _context = context;
        }

        // GET: Pessoas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pessoa.ToListAsync());
        }


        // GET: Pessoas/Create
        public IActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View(new Pessoa());
            else
                return View(_context.Pessoa.Find(id));
        }

        // POST: Pessoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("CadastroId,Nome,CPF,Endereco,Telefone,CEP,Bairro,Estado,Cidade")] Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                if (pessoa.CadastroId == 0)
                    _context.Add(pessoa);
                else
                    _context.Update(pessoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pessoa);
        }

        


        // GET: Pessoas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var pessoa = await _context.Pessoa.FindAsync(id);
            _context.Pessoa.Remove(pessoa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
