public class StudentRepository
{
    private SchoolContext _context;

    public StudentRepository(SchoolContext context)
    {
        _context = context;
    }

    public async Task DeleteStudentAsync(int id)
    {
        Student Student = await _context.Students.FindAsync(id);
        _context.Students.Remove(Student);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateStudentAsync(Student student)
    {
        _context.Students.Update(Student);
        await _context.SaveChangesAsync();
    }

    public async Task CreateStudentAsync(Student student)
    {
        _context.Students.Update(Student);
        await _context.SaveChangesAsync();
    }

    public async Task<Student> GetStudentByIdAsync(int id)
    {
        return await _context.Students.FindAsync(id);
    }

    public async Task<List<Student>> GetStudentsAsync()
    {
        return await _context.Students.ToListAsync();
    }

    public async Task<Student> GetStudentById(int? id)
    {
        return await _context.Students.FindAsync(id);
    }

}
