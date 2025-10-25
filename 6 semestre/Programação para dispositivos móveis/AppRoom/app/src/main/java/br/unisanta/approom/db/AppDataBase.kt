package br.unisanta.approom.db

import androidx.room.Database
import androidx.room.RoomDatabase
import br.unisanta.approom.dao.UserDao
import br.unisanta.approom.model.User

@Database(entities = [User::class], version = 1)
abstract class AppDataBase : RoomDatabase() {
    abstract fun userDao():UserDao
}