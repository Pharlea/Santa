package br.unisanta.App_Login

import android.R
import android.content.Intent
import android.os.Bundle
import android.view.View
import androidx.appcompat.app.AppCompatActivity


class MainActivity : AppCompatActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        edtEmail = findViewById<View>(R.id.edt_email)
        edtSenha = findViewById<View>(R.id.edt_senha)
        btnEnviar = findViewById<View>(R.id.btn_logar)

        btnEnviar.setOnClickListener(View.OnClickListener { // Pegar os valores digitados
            val email: String = edtEmail.getText().toString()
            val senha: String = edtSenha.getText().toString()

            // Criar Intent para abrir a segunda tela
            val intent = Intent(
                this@MainActivity,
                SegundaActivity::class.java
            )

            intent.putExtra("email", email)
            intent.putExtra("senha", senha)
            startActivity(intent)
        })
    }
}