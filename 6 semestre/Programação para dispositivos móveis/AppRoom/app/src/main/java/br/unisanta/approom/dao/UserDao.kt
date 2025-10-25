package br.unisanta.approom.dao

import androidx.room.Dao
import androidx.room.Insert
import androidx.room.Query
import br.unisanta.approom.model.User

@Dao
interface UserDao {
    @Query("SELECT * FROM USER")
    fun selectAll():List<User>
    @Insert
    suspend fun insertUser(user:User)
}