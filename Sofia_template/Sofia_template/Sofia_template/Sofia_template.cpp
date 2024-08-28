#include <iostream>
#include <vector>
#include <string>
#include <cstdlib>
using namespace std;

class Entity {
public:
    int* bag;
    int life;
    int damage;

    Entity(int bagSize, int life, int damage) : life(life), damage(damage) {
        cout << "Полный конструктор: " << this << endl;
        bag = new int[bagSize];
        for (int i = 0; i < bagSize; i++) {
            bag[i] = rand() % 100;
        }
    }

    Entity() {
        cout << "Конструктор по умолчанию: " << this << endl;
        bag = nullptr;
        life = 0;
        damage = 0;
    }
    void set_life(int newLife) {
        cout << "Старая жизнь: " << life << ", Новая жизнь: " << newLife << endl;
        life = newLife;
    }

    void set_damage(int newDamage) {
        cout << "Старый урон: " << damage << ", Новый урон: " << newDamage << endl;
        damage = newDamage;
    }
    Entity(const Entity& obj) {
        cout << "Конструктор копирования: " << this << endl;
        life = obj.life;
        damage = obj.damage;
        if (obj.bag != nullptr) {
            bag = new int[sizeof(obj.bag) / sizeof(*obj.bag)];
            copy(obj.bag, obj.bag + sizeof(obj.bag) / sizeof(*obj.bag), bag);
        }
        else {
            bag = nullptr;
        }
    }

    Entity(Entity&& obj) {
        cout << "Конструктор перемещения: " << this << endl;
        life = obj.life;
        damage = obj.damage;
        bag = obj.bag;
        obj.bag = nullptr;
    }

    ~Entity() {
        cout << "Деструктор: " << this << endl;
        delete[] bag;
    }

    Entity& operator=(const Entity& obj) {
        cout << "Оператор присваивания: " << this << endl;
        if (this != &obj) {
            delete[] bag;
            life = obj.life;
            damage = obj.damage;
            if (obj.bag != nullptr) {
                bag = new int[sizeof(obj.bag) / sizeof(*obj.bag)];
                copy(obj.bag, obj.bag + sizeof(obj.bag) / sizeof(*obj.bag), bag);
            }
            else {
                bag = nullptr;
            }
        }
        return *this;
    }

    Entity& operator=(Entity&& obj) {
        cout << "Оператор перемещения: " << this << endl;
        if (this != &obj) {
            delete[] bag;
            life = obj.life;
            damage = obj.damage;
            bag = obj.bag;
            obj.bag = nullptr;
        }
        return *this;
    }

    void print() {
        cout << "Жизнь: " << life << ", Урон: " << damage << ", Сумка: ";
        for (int i = 0; i < sizeof(bag) / sizeof(bag[0]); i++) {
            cout << bag << " ";
        }
        cout << endl;
    }

    void set_bag(int bagSize) {
        delete[] bag;
        bag = new int[bagSize];
        for (int i = 0; i < bagSize; i++) {
            bag[i] = rand() % 100;
        }
    }

    static Entity bagLoader(int size) {
        Entity entity(size, rand() % 100, rand() % 100);
        return entity;
    }
};

class Human : public Entity {
public:
    int intelligence;

    Human(int bagSize, int life, int damage, int intelligence)
        : Entity(bagSize, life, damage), intelligence(intelligence) {}

    double thinking() {
        return damage * (0.01 * intelligence);
    }
};

class Monster : public Entity {
public:
    int scary;

    Monster(int bagSize, int life, int damage, int scary)
        : Entity(bagSize, life, damage), scary(scary) {}

    double Boo() {
        return damage * scary;
    }
};

class Friend : public Entity {
public:
    int friendship;

    Friend(int bagSize, int life, int damage, int friendship)
        : Entity(bagSize, life, damage), friendship(friendship) {}

    double healing(Human& human) {
        return human.life + friendship * 0.01;
    }
};


template<typename T>
class Tentity {
public:
    T curObj;

    Tentity(T& a) : curObj{ a } {}

    void set_life(int newLife) {
        cout << "Старая жизнь: " << curObj.life << ", Новая жизнь: " << newLife << endl;
        curObj.life = newLife;
    }

    void set_damage(int newDamage) {
        cout << "Старый урон: " << curObj.damage << ", Новый урон: " << newDamage << endl;
        curObj.damage = newDamage;
    }

    void bagLoader(int size) {
        curObj.set_bag(size);
        cout << "Результат работы bagLoader: ";
        curObj.print();
    }
    vector<string> convertToStringArray() {
        vector<string> result;

        // Получение данных и методов объекта T и преобразование их в строки
        string lifeStr = "Жизнь: " + to_string(curObj.life);
        string damageStr = "Урон: " + to_string(curObj.damage);

        // Добавление данных и методов в массив строк
        result.push_back(lifeStr);
        result.push_back(damageStr);

        // Дополнительные действия для каждого класса
        if constexpr (is_same<T, Human>::value) {
            string intelligenceStr = "Интеллект: " + to_string(curObj.intelligence);
            result.push_back(intelligenceStr);
        }
        else if constexpr (is_same<T, Monster>::value) {
            string scaryStr = "Страшность: " + to_string(curObj.scary);
            result.push_back(scaryStr);
        }
        else if constexpr (is_same<T, Friend>::value) {
            string friendshipStr = "Дружба: " + to_string(curObj.friendship);
            result.push_back(friendshipStr);
        }

        return result;
    }
};
int main() {
    setlocale(LC_ALL, "rus");
    Entity entity1(5, 100, 50);
    entity1.print();

    // Создание объекта Entity с использованием конструктора по умолчанию
    Entity entity2;
    entity2.print();

    // Создание объекта Entity с использованием конструктора копирования
    Entity entity3 = entity1;
    entity3.print();

    // Создание объекта Entity с использованием конструктора перемещения
    Entity entity4 = move(entity2);
    entity4.print();

    // Использование оператора присваивания
    entity3 = entity4;
    entity3.print();

    // Использование оператора перемещения
    entity4 = move(entity1);
    entity4.print();

    // Изменение значения поля life
    entity4.set_life(75);
    entity4.print();

    // Изменение значения поля damage
    entity4.set_damage(30);
    entity4.print();

    // Загрузка случайных чисел в сумку объекта Entity
    entity4.bagLoader(10);

    Human h1(5, 100, 50, 80);
    int thought = h1.thinking();

    Monster m1(5, 100, 50, 2);
    int scare = m1.Boo();

    Friend f1(5, 100, 50, 10);
    int healedLife = f1.healing(h1);

    //Human human(3, 80, 40, 90);
    Tentity<Human> tentity1(h1);
    vector<string> humanData = tentity1.convertToStringArray();

    // Вывод данных объекта Human
    for (const auto& data : humanData) {
        cout << data << endl;
    }

    // Создание объекта Monster
    Monster monster(4, 120, 60, 3);

    // Использование шаблонного класса Tentity для объекта Monster
    Tentity<Monster> tentity2(monster);
    vector<string> monsterData = tentity2.convertToStringArray();

    // Вывод данных объекта Monster
    for (const auto& data : monsterData) {
        cout << data << endl;
    }

    // Создание объекта Friend
    Friend friendObj(2, 90, 45, 5);

    // Использование шаблонного класса Tentity для объекта Friend
    Tentity<Friend> tentity3(friendObj);
    vector<string> friendData = tentity3.convertToStringArray();

    // Вывод данных объекта Friend
    for (const auto& data : friendData) {
        cout << data << endl;
    }
    return 0;
}