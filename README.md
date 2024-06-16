# GunProperties
Добавляет на ваш сервер инструменты настройки урона от оружия и ролей!
Плагин использует списки типа "Dictionary", вам достаточно добавить новый тип {урон/роль/оружие} и указать указать {value}

**Базовый config по умполчанию:**
```
GunProperties:
  is_enabled: true
  debug: false
```
```
  # RoleDamage - базовый наносимый урон для роли (SCP)
  roles_damages:
    Scp049: 100
```
```
  # ItemDamage - базовый наносимый урон для оружия
  items_damages:
    A7: 40
```
```
  # HitboxDamage - множитель урона при попадании в часть тела (1 - стандратный урон)
  hitbox_damage:
    Headshot: 2
    Body: 1
    Limb: 0.48
```
