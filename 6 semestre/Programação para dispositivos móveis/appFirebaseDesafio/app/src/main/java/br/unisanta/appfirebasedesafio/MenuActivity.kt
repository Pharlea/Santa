package br.unisanta.appfirebasedesafio

import Pedido
import android.content.Intent
import android.os.Bundle
import android.widget.*
import androidx.appcompat.app.AppCompatActivity
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.google.firebase.Firebase
import com.google.firebase.firestore.firestore

class MenuActivity : AppCompatActivity() {

    private lateinit var recyclerView: RecyclerView
    private lateinit var adapter: PedidoAdapter
    private lateinit var spinnerSabores: Spinner

    private val listaPedidos = ArrayList<Pedido>()
    private val db = Firebase.firestore

    private var emailUsuario = ""
    private var isAdmin = false

    // Lista de opções
    private val sabores = listOf(
        "Hambúrguer Artesanal" to "R$ 24,90",
        "X-Salada" to "R$ 18,00",
        "X-Bacon" to "R$ 22,00",
        "X-Tudo" to "R$ 28,00",
        "Batata Frita" to "R$ 12,00",
        "Refrigerante" to "R$ 7,00"
    )

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_menu)

        // Recebe dados do login
        emailUsuario = intent.getStringExtra("emailUsuario") ?: ""
        isAdmin = intent.getBooleanExtra("isAdmin", false)

        // -------- SPINNER --------
        spinnerSabores = findViewById(R.id.spinner_sabor)

        val nomes = sabores.map { it.first } // Lista só com nomes
        val adapterSpinner = ArrayAdapter(
            this,
            android.R.layout.simple_spinner_item,
            nomes
        )
        adapterSpinner.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item)
        spinnerSabores.adapter = adapterSpinner

        // -------- RECYCLER VIEW --------
        recyclerView = findViewById(R.id.recycler_menu)
        recyclerView.layoutManager = LinearLayoutManager(this)
        adapter = PedidoAdapter(listaPedidos, isAdmin)
        recyclerView.adapter = adapter

        // -------- BOTÃO ADICIONAR --------
        val btnAdicionar = findViewById<Button>(R.id.btn_adicionar_item)
        btnAdicionar.setOnClickListener { adicionarItem() }

        // -------- BOTÃO VER PEDIDOS --------
        val btnVerPedido = findViewById<Button>(R.id.btn_ver_pedido)
        btnVerPedido.setOnClickListener {
            startActivity(
                Intent(this, SideActivity::class.java).apply {
                    putExtra("emailUsuario", emailUsuario)
                    putExtra("isAdmin", isAdmin)
                }
            )
        }
    }

    private fun adicionarItem() {

        val index = spinnerSabores.selectedItemPosition

        val nomeEscolhido = sabores[index].first
        val precoEscolhido = sabores[index].second

        val pedido = Pedido(
            nome = nomeEscolhido,
            preco = precoEscolhido,
            status = "Em espera",
            usuarioEmail = emailUsuario   // <-- ESSENCIAL!
        )

        db.collection("pedidos")
            .add(pedido)
            .addOnSuccessListener {
                Toast.makeText(this, "Pedido enviado!", Toast.LENGTH_SHORT).show()
            }
            .addOnFailureListener {
                Toast.makeText(this, "Erro ao enviar pedido", Toast.LENGTH_SHORT).show()
            }
    }
}
