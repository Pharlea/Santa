package br.unisanta.appfirebasedesafio

import android.content.Intent
import android.os.Bundle
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import br.unisanta.appfirebasedesafio.databinding.ActivityMainBinding
import com.google.firebase.Firebase
import com.google.firebase.firestore.firestore

class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
        val db = Firebase.firestore
        binding.btnIrParaLogin.setOnClickListener{
            val intent = Intent(this, LoginActivity::class.java)
            startActivity(intent)
        }

        binding.btnCadastro.setOnClickListener{
            val email = binding.edtEmail.text.toString()
            val senha = binding.edtSenha.text.toString()

            val usuario = hashMapOf(
                "email" to email,
                "senha" to senha,
                "admin" to false
            )

            db.collection("usuarios").add(usuario).addOnCompleteListener { task ->
                if (task.isSuccessful) {
                    Toast.makeText(this, "Usuário cadastrado com sucesso", Toast.LENGTH_SHORT)
                        .show()
                } else {
                    Toast.makeText(this, "Erro ao cadastrar o usuário", Toast.LENGTH_SHORT)
                        .show()
                }
            }

            binding.edtEmail.text.clear()
            binding.edtSenha.text.clear()

        }
    }
}