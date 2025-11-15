package br.unisanta.appfirebasedesafio

import android.content.Intent
import android.os.Bundle
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import br.unisanta.appfirebasedesafio.databinding.ActivityLoginBinding
import com.google.firebase.Firebase
import com.google.firebase.firestore.firestore

class LoginActivity : AppCompatActivity() {

    private lateinit var binding: ActivityLoginBinding
    private val db = Firebase.firestore

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        binding = ActivityLoginBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.btnIrParaCadastro.setOnClickListener {
            startActivity(Intent(this, MainActivity::class.java))
        }

        binding.btnLogin.setOnClickListener {
            val email = binding.edtEmailLogin.text.toString().trim()
            val senha = binding.edtSenhaLogin.text.toString().trim()

            if (email.isEmpty() || senha.isEmpty()) {
                Toast.makeText(this, "Preencha e-mail e senha!", Toast.LENGTH_SHORT).show()
                return@setOnClickListener
            }

            logarUsuario(email, senha)
        }
    }

    private fun logarUsuario(email: String, senha: String) {

        db.collection("usuarios")
            .whereEqualTo("email", email)
            .get()
            .addOnSuccessListener { result ->

                if (result.isEmpty) {
                    Toast.makeText(this, "Usuário não encontrado!", Toast.LENGTH_SHORT).show()
                    return@addOnSuccessListener
                }

                val doc = result.documents[0]
                val senhaBanco = doc.getString("senha")
                val admin = doc.getBoolean("admin") ?: false

                if (senhaBanco == senha) {

                    Toast.makeText(this, "Login realizado!", Toast.LENGTH_SHORT).show()

                    val intent = Intent(this, MenuActivity::class.java)
                    intent.putExtra("emailUsuario", email)
                    intent.putExtra("isAdmin", admin)
                    startActivity(intent)
                    finish()

                } else {
                    Toast.makeText(this, "Senha incorreta!", Toast.LENGTH_SHORT).show()
                }
            }
    }

}
