var Person = Class.create({
    init: function (fname, lname, age) {
        this.fname = fname;
        this.lname = lname;
        this.age = age;
    },
    introduce: function () {
        return "Name:" + this.fname + " " + this.lname + ", Age: " + this.age;
    }
});

var Student = Class.create({
    init: function (fname, lname, age, grade) {
        this._super = new this._super(arguments);
        this._super.init(fname, lname, age);
        this.grade = grade;
    },
    introduce: function () {
        return this._super.introduce() + ", grade: " + this.grade;
    }
});

Student.inherit(Person);

var Teacher = Class.create({
    init: function (fname, lname, age, speciality) {
        this._super = new this._super(arguments);
        this._super.init(fname, lname, age);
        this.speciality = speciality;
    },
    introduce: function () {
        return this._super.introduce() + ", speciality: " + this.speciality;
    }
});

Teacher.inherit(Person);

var Course = Class.create({
    init: function (name, capacity, students, formTeacher) {
        this.name = name;
        this.capacity = capacity;
        this.students = students;
        this.formTeacher = formTeacher;
    }
});

var School = Class.create({
    init: function (name, town, classes) {
        this.name = name;
        this.town = town;
        this.classes = classes;
    }
});