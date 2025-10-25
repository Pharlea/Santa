package br.unisanta.approom.view

import android.os.Bundle
import android.util.Log
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import androidx.lifecycle.lifecycleScope
import androidx.room.Room
import androidx.room.RoomDatabase
import br.unisanta.approom.R
import br.unisanta.approom.dao.UserDao
import br.unisanta.approom.databinding.ActivityMainBinding
import br.unisanta.approom.db.AppDataBase
import br.unisanta.approom.model.User
import kotlinx.coroutines.Dispatchers
import kotlinx.coroutines.launch
import kotlinx.coroutines.withContext

class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding
    private lateinit var db:AppDataBase
    private lateinit var dao:UserDao

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
        db = Room.databaseBuilder(
            applicationContext,
            AppDataBase::class.java,
            "db_user"
        ).fallbackToDestructiveMigration()
            .build()

        dao = db.userDao()

        binding.btnSave.setOnClickListener{
            val firstName = binding.edtFirstName.text.toString()
            val lastName = binding.edtLastName.text.toString()
            val user = User(0, firstName, lastName)
            lifecycleScope.launch {
                dao.insertUser(user)
            }
            binding.edtFirstName.text.clear()
            binding.edtLastName.text.clear()
            Toast.makeText(applicationContext, "Cadastrado", Toast.LENGTH_SHORT)
                .show()
        }
        binding.btnFind.setOnClickListener{
            lifecycleScope.launch {
                val list = withContext(Dispatchers.IO){
                    dao.selectAll()
                }
                list.forEach {
                    Log.d("USER", "ID: ${it.Uid} - Nome: ${it.firstName}" +
                            " - sobrenome: ${it.lastName}")
                }
            }
            Toast.makeText(this, "Consulte o LogCat!", Toast.LENGTH_SHORT).show()
        }
    }
}