using AutoMapper;
using Fluxor;
using QueryExpressPlusPlus.Features.About.Store;

namespace QueryExpressPlusPlus.WinformsMdiApp.Features.About.Pages;

partial class AboutForm : Form
{
    private readonly IDispatcher _dispatcher;
    private readonly IState<AboutState> _aboutState;
    private readonly IMapper _mapper;

    public AboutForm(
        IDispatcher dispatcher,
        IState<AboutState> aboutState,
        IMapper mapper)
    {
        InitializeComponent();
        _dispatcher = dispatcher;
        _aboutState = aboutState;
        _mapper = mapper;

        _aboutState.StateChanged += _aboutState_StateChanged;
        if (!aboutState.Value.IsInitialized)
        {
            _aboutState_StateChanged(this, new());
        }

        _dispatcher.Dispatch(new AboutLoadAssemblyInfoAction());

        var foo = DateTimeOffset.Now.ToString();
    }

    private void _aboutState_StateChanged(object? sender, EventArgs e)
        => _mapper.Map(_aboutState.Value, this);

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AboutState, AboutForm>()
            .ForPath(dest => dest.Text, opt => opt.MapFrom(src => src.Title))
            .ForPath(dest => dest.Cursor, opt => opt.MapFrom(src => src.IsLoading ? Cursors.WaitCursor : Cursors.Default))
            .ForPath(dest => dest.lblProductName.Text, opt => opt.MapFrom(src => src.ProductName))
            .ForPath(dest => dest.lblVersion.Text, opt => opt.MapFrom(src => src.Version))
            .ForPath(dest => dest.lblCopyright.Text, opt => opt.MapFrom(src => src.Copyright))
            .ForPath(dest => dest.lblInformationalVersion.Text, opt => opt.MapFrom(src => src.InformationalVersion))
            .ForPath(dest => dest.txtDescription.Text, opt => opt.MapFrom(src => src.Description));
        }
    }
}
