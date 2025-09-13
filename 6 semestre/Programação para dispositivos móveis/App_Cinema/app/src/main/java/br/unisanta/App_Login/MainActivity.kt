package br.unisanta.App_Login

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.CheckBox
import android.widget.EditText
import android.widget.SeekBar
import androidx.appcompat.app.AppCompatActivity
import br.unisanta.App_Login.R

class MainActivity : AppCompatActivity(R.layout.activity_main) {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)

        val edtNome = findViewById<EditText>(R.id.edt_nome)
        val tbAcao = findViewById<CheckBox>(R.id.cb_acao)
        val tbComedia = findViewById<CheckBox>(R.id.cb_comedia)
        val tbRomance = findViewById<CheckBox>(R.id.cb_romance)
        val tbAnimacao = findViewById<CheckBox>(R.id.cb_animacao)
        val tbDrama = findViewById<CheckBox>(R.id.cb_drama)
        val tbTerror = findViewById<CheckBox>(R.id.cb_terror)
        val skbNota = findViewById<SeekBar>(R.id.skb_nota)
        val btnAdicionar = findViewById<Button>(R.id.btn_adicionar_filme)
        val btnVerLista = findViewById<Button>(R.id.btn_ver_lista)

        // Botão para adicionar filme à lista global
        btnAdicionar.setOnClickListener {
            val nomeFilme = edtNome.text.toString().trim()
            if (nomeFilme.isEmpty()) {
                edtNome.error = "Informe o nome do filme"
                return@setOnClickListener
            }

            // Todos os gêneros selecionados
            val generos = mutableListOf<String>()
            if (tbAcao.isChecked) generos.add("Ação")
            if (tbComedia.isChecked) generos.add("Comédia")
            if (tbRomance.isChecked) generos.add("Romance")
            if (tbAnimacao.isChecked) generos.add("Animação")
            if (tbDrama.isChecked) generos.add("Drama")
            if (tbTerror.isChecked) generos.add("Terror")
            if (generos.isEmpty()) generos.add("Indefinido")

            val nota = skbNota.progress.toString()
            val generosString = generos.joinToString(", ")

            // Criar objeto Filme e adicionar ao repositório
            val filme = Filme(nomeFilme, generosString, nota)
            FilmeRepository.filmes.add(filme)

            // Limpar campos
            edtNome.text.clear()
            tbAcao.isChecked = false
            tbComedia.isChecked = false
            tbRomance.isChecked = false
            tbAnimacao.isChecked = false
            tbDrama.isChecked = false
            tbTerror.isChecked = false
            skbNota.progress = 0
        }

        // Botão para abrir a lista de filmes
        btnVerLista.setOnClickListener {
            val intent = Intent(this, SideActivity::class.java)
            startActivity(intent)
        }
    }
}
