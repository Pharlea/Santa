package br.unisanta.appfirebasedesafio

import Pedido
import android.os.Bundle
import android.widget.Button
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.google.firebase.Firebase
import com.google.firebase.firestore.firestore

class SideActivity : AppCompatActivity() {

    private lateinit var recyclerView: RecyclerView
    private lateinit var adapter: PedidoAdapter
    private var pedidos = ArrayList<Pedido>()

    private val db = Firebase.firestore
    private var emailUsuario = ""
    private var isAdmin = false

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_side)

        emailUsuario = intent.getStringExtra("emailUsuario") ?: ""
        isAdmin = intent.getBooleanExtra("isAdmin", false)

        recyclerView = findViewById(R.id.rcv_pedidos)
        recyclerView.layoutManager = LinearLayoutManager(this)

        adapter = PedidoAdapter(pedidos, isAdmin)
        recyclerView.adapter = adapter

        carregarPedidos()

        findViewById<Button>(R.id.btn_volta).setOnClickListener {
            finish()
        }
    }

    private fun carregarPedidos() {

        val query = if (isAdmin) {
            db.collection("pedidos")
        } else {
            db.collection("pedidos").whereEqualTo("usuarioEmail", emailUsuario)
        }

        query.get()
            .addOnSuccessListener { result ->
                pedidos.clear()
                for (doc in result) {
                    val p = doc.toObject(Pedido::class.java)
                    p.status = doc.getString("status") ?: "Em espera"
                    pedidos.add(p)
                }
                adapter.notifyDataSetChanged()
            }
    }
}
