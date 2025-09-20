package unisanta.br.tpdesafio

import android.content.Intent
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.SeekBar
import android.widget.TextView
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity(R.layout.activity_main) {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val edtTitulo = findViewById<EditText>(R.id.edt_titulo)
        val edtDescricao = findViewById<EditText>(R.id.edt_descricao)
        val skNota = findViewById<SeekBar>(R.id.sk_nota)
        val edtLink = findViewById<EditText>(R.id.edt_link)
        val btnAdicionarFilme = findViewById<Button>(R.id.bt_adicionar_filme)
        val tvLista = findViewById<TextView>(R.id.tv_lista)

        /*
        * Botão de adicionar
        */

        btnAdicionarFilme.setOnClickListener {
            val nomeFilme = edtTitulo.text.toString().trim()
            if (nomeFilme.isEmpty()) {
                edtTitulo.error = "Informe o nome do filme"
                return@setOnClickListener
            }
            val descrcaoFilme = edtDescricao.text.toString().trim()
            if (descrcaoFilme.isEmpty()) {
                edtTitulo.error = "Informe a descrição do filme"
                return@setOnClickListener
            }
            val linkFilme = edtLink.text.toString().trim()
            if (linkFilme.isEmpty()) {
                edtTitulo.error = "Informe o link do filme"
                return@setOnClickListener
            }

            val nota = skNota.progress.toString()

            val filme = Filme(nomeFilme, descrcaoFilme, nota, linkFilme);
            FilmeRepository.filmes.add(filme)

            edtTitulo.text.clear();
            edtDescricao.text.clear();
            edtLink.text.clear();
            skNota.progress = 0;
        }

        /*
        * Link para visualizar
        */
        tvLista.setOnClickListener {
            val intent = Intent(this, VideoVisualizerActivity::class.java)
            startActivity(intent)
        }
    }
}