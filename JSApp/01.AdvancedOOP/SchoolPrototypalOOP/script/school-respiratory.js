var Person = Object.create({
    init: function (fName, lName, age) {
        this.fName = fName;
        this.lName = lName;
        this.age = age;
    },
    introduce: function () {
        return "Name: " + this.fName + " " + this.lName + ", Age: " + this.age;
    }
});

var Student = Person.extend({
    init: function (fName, lName, age, grade) {
        this._super = Object.create(this._super);
        this._super.init(fName, lName, age);
        this.grade = grade;
    },
    introduce: function () {
        return this._super.introduce() + ", Grade: " + this.grade;
    }
});

var Teacher = Person.extend({
    init: function (fName, lName, age, speciality) {
        this._super = Object.create(this._super); 
        this._super.init(fName, lName, age);
        this.speciality = speciality;
    },
    introduce: function () {
        return this._super.introduce() + " Speciality: " + this.speciality;
    }
});

var Course = Object.create({
    init: function (name, studentsCapacity, studentsSet, formTeacher) {
        this.name = name;
        this.studentsCapacity = studentsCapacity;
        this.studentsSet = studentsSet;
        this.formTeacher = formTeacher;
    }
});

var School = Object.create({
    init: function (name, town, classes) {
        this.name = name;
        this.town = town;
        this.classes = classes;
    }
});
