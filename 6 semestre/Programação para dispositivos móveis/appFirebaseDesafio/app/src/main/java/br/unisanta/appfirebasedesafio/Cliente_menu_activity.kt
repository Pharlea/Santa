package br.unisanta.appfirebasedesafio

import Pedido
import android.os.Bundle
import android.widget.ArrayAdapter
import android.widget.Button
import android.widget.EditText
import android.widget.Spinner
import android.widget.Toast
import androidx.appcompat.app.AppCompatActivity
import com.google.firebase.Firebase
import com.google.firebase.firestore.firestore


class ClienteMenuActivity : AppCompatActivity() {

    private lateinit var spinner: Spinner
    private lateinit var edtPreco: EditText
    private lateinit var btnFazerPedido: Button

    private val sabores = listOf(
        "Calabresa",
        "Frango com Catupiry",
        "Portuguesa",
        "Quatro Queijos",
        "Marguerita",
        "Chocolate",
        "Carne Seca"
    )

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_cliente_menu)

        val db = Firebase.firestore

        spinner = findViewById(R.id.spinnerSabores)
        edtPreco = findViewById(R.id.edtPreco)
        btnFazerPedido = findViewById(R.id.btnFazerPedido)

        // Preenche spinner com os sabores
        val adapter = ArrayAdapter(
            this,
            android.R.layout.simple_spinner_dropdown_item,
            sabores
        )
        spinner.adapter = adapter

        btnFazerPedido.setOnClickListener {
            val saborEscolhido = spinner.selectedItem.toString()
            val preco = edtPreco.text.toString().trim()

            if (preco.isEmpty()) {
                Toast.makeText(this, "Digite o preço!", Toast.LENGTH_SHORT).show()
                return@setOnClickListener
            }

            val pedido = Pedido(
                nome = saborEscolhido,
                preco = preco,
                status = "Pendente"
            )

            db.collection("pedidos")
                .add(pedido)
                .addOnSuccessListener {
                    Toast.makeText(this, "Pedido enviado!", Toast.LENGTH_SHORT).show()
                    edtPreco.text.clear()
                }
                .addOnFailureListener {
                    Toast.makeText(this, "Erro ao enviar pedido", Toast.LENGTH_SHORT).show()
                }
        }
    }
}
