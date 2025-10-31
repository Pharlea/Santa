package br.unisanta.appfirebase

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.Toast
import br.unisanta.appfirebase.databinding.ActivityMainBinding
import com.google.firebase.auth.FirebaseAuth

class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding
    private lateinit var auth: FirebaseAuth
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)
        auth = FirebaseAuth.getInstance()

        binding.btnLogar.setOnClickListener{
            val email = binding.edtEmail.text.toString()
            val senha = binding.edtSenha.text.toString()
            auth.signInWithEmailAndPassword(email, senha).addOnCompleteListener { task ->
                if (task.isSuccessful){
                Toast.makeText(applicationContext, "Sucesso!", Toast.LENGTH_SHORT).show()
            }else {
                    Toast.makeText(applicationContext, "Falhou ${task.exception?.message.toString()}", Toast.LENGTH_SHORT).show()
            }
        }
        }
    }
}