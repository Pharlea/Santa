package br.unisanta.App_Login

import MySideAdapter
import android.os.Bundle
import android.widget.Button
import androidx.appcompat.app.AppCompatActivity
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import br.unisanta.App_Login.R

class SideActivity : AppCompatActivity() {

    private lateinit var recyclerView: RecyclerView
    private lateinit var myAdapter: MySideAdapter

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_side)

        recyclerView = findViewById(R.id.rcv_lista_filmes)
        recyclerView.layoutManager = LinearLayoutManager(this)

        // Adapter com a lista global
        myAdapter = MySideAdapter(FilmeRepository.filmes)
        recyclerView.adapter = myAdapter

        // Botão Voltar
        val btnVolta = findViewById<Button>(R.id.btn_volta)
        btnVolta.setOnClickListener { finish() }
    }
}
