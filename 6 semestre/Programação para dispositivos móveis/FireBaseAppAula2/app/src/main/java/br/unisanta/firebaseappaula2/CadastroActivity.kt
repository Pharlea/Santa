package br.unisanta.firebaseappaula2

import android.os.Bundle
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import br.unisanta.firebaseappaula2.databinding.ActivityCadastroBinding
import com.google.firebase.Firebase
import com.google.firebase.firestore.firestore

class CadastroActivity : AppCompatActivity() {
    private lateinit var binding: ActivityCadastroBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        binding = ActivityCadastroBinding.inflate(layoutInflater)
        setContentView(binding.root)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
        val db = Firebase.firestore
        binding.btnCadastrar.setOnClickListener {
            val nome = binding.edtNome.text.toString()
            val preco = binding.edtPreco.text.toString().toDouble()
            val quantidade = binding.edtQuantidade.text.toString().toInt()

            val produto = hashMapOf(
                "nome" to nome,
                "preco" to preco,
                "quantidade" to quantidade
            )
            db.collection("produtos")
                .add(produto).addOnCompleteListener { task ->
                    if (task.isSuccessful) {
                        Toast.makeText(this, "Produto cadastrado com sucesso", Toast.LENGTH_SHORT)
                            .show()
                    } else {
                        Toast.makeText(this, "Erro ao cadastrar o rpoduto", Toast.LENGTH_SHORT)
                            .show()
                    }
                }

            binding.edtNome.text.clear()
            binding.edtPreco.text.clear()
            binding.edtQuantidade.text.clear()

        }
    }
}